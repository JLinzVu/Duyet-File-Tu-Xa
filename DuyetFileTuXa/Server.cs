using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuyetFileTuXa
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.DragEnter += new DragEventHandler(dropBox_DragEnter);
            this.DragDrop += new DragEventHandler(dropBox_DragDrop);
            Connect();
        }
        FileInfo fileInfo;
        public static string path="Desktop/";
        public static string MessageCurrent = "Stopped";
        private void dropBox_DragEnter(object sender, DragEventArgs e)
        {
            dropBox.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            
        }

        private void dropBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            
            foreach (string file in files)
            {
                dropBox.Items.Add(file);
                fileInfo = new FileInfo(file);
            }
            
            dropBox.Enabled = false;
            btnOpenFile.Enabled = false;
            
        }
        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;
        void Connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 8080);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);

                        Thread receive = new Thread(Receive);
                        
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 8080);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }
        void Close()
        {
            server.Close();
        }
        string datas;
        string name;
        bool check = true;
        string linktemp;
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            while (true)
            {
                try
                {
                    if (check == true)
                    {
                        byte[] data = new byte[1024 * 5000];
                        client.Receive(data);
                        string message = Deserialize(data).ToString();
                        switch (message.Substring(0, 3))
                        {
                            case "00:":
                                {
                                    AddMessage(message.Substring(3));
                                    foreach (Socket item in clientList)
                                    {
                                        item.Send(Serialize(message.Substring(3)));
                                    }
                                    break;
                                }
                            case "02:":
                                {
                                    this.BeginInvoke((MethodInvoker)delegate            //update the GUI from another thread
                                    {
                                        dropBox.Items.Clear();
                                        dropBox.Enabled = true;
                                    });
                                    break;
                                }
                            case "03:":
                                {
                                    check = false;
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
                    }
                    else
                    {
                        byte[] datas = new byte[1024 * 5000];
                        int size = client.Receive(datas);
                        string[] s = Encoding.ASCII.GetString(datas, 0, size).Split(new char[] { ',' });
                        long length = long.Parse(s[1]);
                        byte[] buffer = new byte[1024 * 5000];
                        byte[] fsize = new byte[length];
                        long n = length / buffer.Length;
                        for (int i = 0; i < n || i == 0; i++)
                        {
                            size = client.Receive(fsize, fsize.Length, SocketFlags.None);
                            AddMessage("Received frame {" + i + "}/{" + n + "}");
                            if (i == n - 1 || i == n)
                            {
                                check = true;
                                client.Send(Serialize("02:"));
                            }
                        }
                        this.BeginInvoke((MethodInvoker)delegate            //update the GUI from another thread
                        {
                            FolderBrowserDialog ofd = new FolderBrowserDialog();      // chọn đường dẫn để lưu file
                            ofd.ShowDialog();
                            FileStream fs = new FileStream(ofd.SelectedPath + "/" + s[0], FileMode.Create);
                            linktemp = ofd.SelectedPath + "/" + s[0];
                            fs.Write(fsize, 0, fsize.Length);
                            fs.Close();
                            dropBox.Items.Clear();
                            dropBox.Enabled = true;
                            openandeditfile.Visible = true;
                        });
                    }
                }
                catch
                {
                    clientList.Remove(client);
                    
                }
            }
        }
        
        void AddMessage(string s)
        {
            listMess.Text += (s+"\n").ToString();
        }
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            foreach (Socket client in clientList)
            {
                client.Send(Serialize("03:"));
                Thread.Sleep(100);
                byte[] data = new byte[1024 * 5000];
                byte[] fsize = new byte[fileInfo.Length];
                FileStream fs = new FileStream(fileInfo.FullName, FileMode.Open);
                fs.Read(fsize, 0, fsize.Length);
                fs.Close();
                while (true)
                {
                    string s = fileInfo.Name + "," + fileInfo.Length.ToString();
                    client.Send(Encoding.ASCII.GetBytes(s));
                    long n = fileInfo.Length / data.Length;  //tính số frame phải gửi đi

                    for (int i = 0; i < n || i == 0; i++)
                    {
                        client.Send(fsize, fsize.Length, 0);
                        AddMessage("Send frame {" + i + "}/{" + fsize.Length + "}");
                        Thread.Sleep(100);
                    }
                    break;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            dropBox.Visible = true;
            dropBox.Items.Add(fs.Name);
            fileInfo = new FileInfo(fs.Name);
            fs.Close();
        }



        private void btnSendMess_Click(object sender, EventArgs e)
        {
            AddMessage(txtMess.Text);
            foreach (Socket item in clientList)
            {
                item.Send(Serialize("00:Server:" + txtMess.Text));
            }
            this.BeginInvoke((MethodInvoker)delegate         
            {
                txtMess.Text = "";
            });
        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {
            XuliFile xuliFile = new XuliFile(linktemp);
            xuliFile.Show();
        }
    }
}

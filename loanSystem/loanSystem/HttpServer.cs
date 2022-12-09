namespace loanSystem;

using System;
using System.Net;
using System.IO;
using System.Text.Json;


public class HttpServer
{
    public int Port = 8080;

    private HttpListener _listener;
    List<User> _userList;
    DeviceLender _deviceLender;
    
    public HttpServer(List<User> userList, DeviceLender deviceLender)
    {
        _userList = userList;
        _deviceLender = deviceLender;
    }

    public void Start()
    {
        _listener = new HttpListener();
        _listener.Prefixes.Add("http://localhost:" + Port.ToString() + "/");
        _listener.Start();
        Receive();
    }

    public void Stop(){
    
        _listener.Stop();
    }

    private void Receive()
    {
        _listener.BeginGetContext(new AsyncCallback(ListenerCallback), _listener);
    }

    private void ListenerCallback(IAsyncResult result)
    {
        if (_listener.IsListening)
        {
            HttpListenerContext context = _listener.EndGetContext(result);
            HttpListenerRequest request = context.Request;
           

            switch (request.Url.AbsolutePath)
            {
                case "/slik":
                    User user = new User("lol hansen", "123243435", "sdsd@sdsd.adsd");
                    User auser = new User("Abi hansen", "123243435", "sdsd@sdsd.adsd");
                    _userList.Add(user);
                    _userList.Add(auser);
                    var json = JsonSerializer.Serialize(_userList);
                    Console.WriteLine(json);
                    
                    Console.WriteLine("Printing user list!\n");
                    foreach (var _user in _userList)
                    {
                        Console.WriteLine(_user.Name);
                    }
                    
                    byte[] buffer = System.Text.Encoding.UTF8.GetBytes(json); 
                    context.Response.ContentLength64 = buffer.Length;
                    Stream output = context.Response.OutputStream;
                    output.Write(buffer,0,buffer.Length);
                    
                    //context.Response.OutputStream.Write(buffer);
                    break;
            }
            
            // do something with the request
            //Console.WriteLine($"{request.Url}");

            Receive();
        }
    }
}
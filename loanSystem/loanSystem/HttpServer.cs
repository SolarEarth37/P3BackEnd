namespace loanSystem;

using System;
using System.Net;
using System.IO;

public class HttpServer
{
    public int Port = 8080;

    private HttpListener _listener;

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
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes("<HTML><BODY> " + "HEllo World" + "</BODY></HTML>");

            switch (request.Url.AbsolutePath)
            {
                case "/slik":
                    Console.WriteLine("Sour BredBaand");
                    context.Response.OutputStream.Write(buffer);
                    break;
            }
            
            // do something with the request
            //Console.WriteLine($"{request.Url}");

            Receive();
        }
    }
}
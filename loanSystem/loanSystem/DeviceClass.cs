using System;
namespace loanSystem
{
    public class DeviceClass
    {
        public int Id;
        public double DeviceNumber;
        public string Name;
        public enum Status
        {
            Editor,
            Viewer
        }

        public DeviceClass(int Id, double DeviceNumber, string Name, enum Status)
		{
			deviceName = Id;
			deviceNumber = DeviceNumber;
			deviceName = Name;
			deviceStatus = Status; 


		}

    static void main(string[] args)
    {
        public 
        
        
    }

interface IWorkflow
{
    void Execute();
}

class VideoUploader : IWorkflow
{
    public void Execute()
    {
        Console.WriteLine("Uploading a video!");
    }
}

class CallWebService : IWorkflow
{
    public void Execute()
    {
        Console.WriteLine("Calling web service....");
    }

}
class SendEmail : IWorkflow
{
    public void Execute()
    {
        Console.WriteLine("Send an email...");
    }
}
class ChangeStaus : IWorkflow
{
    public void Execute()
    {
        Console.WriteLine("Statue changed...");
    }
}
class WorkFlowEngine
{
    private List<IWorkflow> T;

    public WorkFlowEngine()
    {
        T = new List<IWorkflow>();
    }
    public void AddWorkFlowObject(IWorkflow iObject)
    {
        T.Add(iObject);
    }
    public void RemoveWorkFlowObject(IWorkflow iObject)
    {
        T.Remove(iObject);
    }

    public void Run()
    {
        foreach (IWorkflow I in T)
        {
            I.Execute();
        }
    }
}
}



}
}
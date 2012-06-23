using System;
using System.Xml;
using System.IO;
using System.Reflection;

namespace UnityExternalScriptEditorHelper
{
class MainClass
{
public static void Main(string[] args)
{
    string exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

    // Get logPath and clear log
    string logPath = Path.Combine(exeDir, "UnityExternalScriptEditorHelper.log");
    File.Delete(logPath);

    File.AppendAllText(logPath, "*****args*****"+Environment.NewLine);
    File.AppendAllLines(logPath, args);
    
    // Get arguments unity is trying to launch with
    string[] launchParams = args[args.Length-1].Split(';');
    string launchFile = launchParams[0];
    string launchLine = launchParams[1];
    
    File.AppendAllText(logPath, "*****launchParams*****"+Environment.NewLine);
    File.AppendAllLines(logPath, launchParams);
    
    // Get the configuration
    string configPath = Path.Combine(exeDir, "UnityExternalScriptEditorHelper.xml");
    XmlDocument xml = new XmlDocument();
    xml.Load(configPath);
    
    string launchApplication = xml.SelectSingleNode("//application/text()").Value;
    string launchArguments = xml.SelectSingleNode("//arguments/text()").Value;
    
    launchArguments = launchArguments.Replace("*file*", launchFile);
    launchArguments = launchArguments.Replace("*line*", launchLine);
    
    File.AppendAllText(logPath, "*****Launching*****"+Environment.NewLine);
    File.AppendAllLines(logPath, new string[] {launchApplication, launchArguments});
    
    // Launch the app    
    System.Diagnostics.Process proc = new System.Diagnostics.Process();
    proc.EnableRaisingEvents = false; 
    proc.StartInfo.FileName = launchApplication;
    proc.StartInfo.Arguments = launchArguments;
    proc.Start();
    
}
}
}

using CliWrap;
public class RunTestsJob
{
    public void Execute(){
        // var cmd = new CliWrap.Command("dotnet","test");        
        CliWrap.Cli.Wrap("dotnet")
            .WithArguments("test")
            .WithWorkingDirectory(Directory.GetCurrentDirectory())
            .WithStandardOutputPipe(PipeTarget.ToDelegate(async output => {

            }));            
        // Process process = new Process
        // {
        //     StartInfo = new ProcessStartInfo
        //     {
        //         FileName = "dotnet",
        //         Arguments = "test", // Specify the arguments for the 'dotnet test' command
        //         RedirectStandardOutput = true,
        //         RedirectStandardError = true,
        //         UseShellExecute = false,
        //         CreateNoWindow = true,
        //     }
        // };

        // process.Start();
        // process.WaitForExit();
    }
}
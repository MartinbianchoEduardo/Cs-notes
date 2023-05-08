using System.Net;

namespace C__AdvancedTopics
{
    internal class AsyncProgramming
    {
        //public async 
        //the return type is a Task - an object that encapsulates the
        //state of an async operation 
        //for void methods = Task
        //for non-void methods - use generic = Task< return Type >
        public async Task DownloadAsync(string url)
        {
            var webClient = new WebClient();
            //this method returns a Task, so await it
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"c:/projects/result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }
    }
}

using System.Collections.Concurrent;
using System.Net.Http;
using System.Threading;
using Serilog;
using Serilog.Configuration;
using Serilog.Events;

namespace Bp.Logging.Sinks.Mattermost
{
    public static class BpMattermostSinkExtensions
    {
        public static LoggerConfiguration BpMattermostSink(
            this LoggerSinkConfiguration loggerConfiguration,
            BpMattermostInfo bpMattermostInfo, BpLogFormatter formatter = null, ConcurrentBag<LogEvent> logs = null, Timer timer = null,
            HttpClient httpClient = null, LogEventLevel restrictedToMinimumLevel = LogEventLevel.Verbose)
        {
            return loggerConfiguration.Sink(new BpMattermostSink(bpMattermostInfo, formatter, httpClient), restrictedToMinimumLevel);
        }
    }
}
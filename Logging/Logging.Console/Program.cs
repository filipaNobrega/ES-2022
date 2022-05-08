using Logging;

var composedRecorder = new ComposedRecorder();
composedRecorder.Append(new DateDecorator(new CounterDecorator(new ConsoleRecorder())));

Logger.Instance.Recorder = composedRecorder;

Logger.Instance.Log("Attempting reconnection...");
Logger.Instance.Log("Terminating existing web socket");
Logger.Instance.Log($"Fetching logs for app: {Guid.NewGuid()}");
Logger.Instance.Log("Logs connection opened");
Logger.Instance.Log("Stopping app...");
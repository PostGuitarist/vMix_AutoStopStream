'Trigger a function at a specific time of day 

dim triggertime as string = "10:25"

'console.writeline ( DateTime.Now.ToString("hh:mm"))

Do While True
     If triggertime = DateTime.Now.ToString("hh:mm") Then
          ' The times match so do something like
           API.Function("StopStreaming",Value:="0")  'replace 0 with the to stream number
          ' And we are done
           Exit do

     End If
     sleep(1000)
Loop

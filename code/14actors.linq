<Query Kind="FSharpProgram" />

type Agent<'T> = MailboxProcessor<'T>

let agent =
   Agent.Start(fun inbox ->
     async { while true do
               let! msg = inbox.Receive()
               printfn "got message '%s'" msg } )
			   
agent.Post "hello!"

// example from http://blogs.msdn.com/b/dsyme/archive/2010/02/15/async-and-parallel-design-patterns-in-f-part-3-agents.aspx
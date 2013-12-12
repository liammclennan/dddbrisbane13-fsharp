<Query Kind="FSharpProgram" />

type Agent<'T> = MailboxProcessor<'T>

// create 100,000 agents
let agents =
    [ for i in 0 .. 100000 ->
       Agent.Start(fun inbox ->
         async { while true do
                   let! msg = inbox.Receive()
				   // write a message if I am a 10,000th agent
                   if i % 10000 = 0 then
                       printfn "agent %d got message '%s'" i msg } ) ]

// send a message to 100,000 agents
for agent in agents do
    agent.Post "ping!"
	
// example from http://blogs.msdn.com/b/dsyme/archive/2010/02/15/async-and-parallel-design-patterns-in-f-part-3-agents.aspx	
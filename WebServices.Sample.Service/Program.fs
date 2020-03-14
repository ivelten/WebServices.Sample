/// Neste arquivo está a estrutura básica para fazer o serviço ser executado.
module WebServices.Sample.Service.Program

open System
open System.Threading
open Suave
open WebServices.Sample.Service.Endpoints

let [<Literal>] ReturnCode = 0

[<EntryPoint>]
let main _ =
    let cts = new CancellationTokenSource()
    let conf = { defaultConfig with cancellationToken = cts.Token }
    let listening, server = startWebServerAsync conf app
        
    Async.Start(server, cts.Token)
    printfn "Pronto para fazer requisições!"
    Console.ReadKey true |> ignore
        
    cts.Cancel()

    ReturnCode

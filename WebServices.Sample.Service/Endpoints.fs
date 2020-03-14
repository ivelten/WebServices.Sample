/// Neste módulo está a organização dos endpoints (serviços) fornecidos pelo WebService.
/// As requisições são feitas em HTTP, e o formato de dados utilizado é JSON.
module WebServices.Sample.Service.Endpoints

open Suave
open Suave.Json
open Suave.Filters
open Suave.Operators
open Suave.Successful
open WebServices.Sample.Service.Contracts

let app =
  choose
    [ GET >=> choose
        [ path "/healthcheck" >=> OK "Service is running." ]
      POST >=> choose
        [ path "/order" >=> mapJson (fun (req : OrderNumbers) -> { Numbers = req.Numbers |> Array.sort }) ] ]
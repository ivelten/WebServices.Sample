/// Neste namespace estão os contratos usados para comunicação via JSON.
namespace WebServices.Sample.Service.Contracts

open System.Runtime.Serialization

[<DataContract>]
type OrderNumbers =
    { [<field : DataMember(Name = "numbers")>]
      Numbers : int[] }
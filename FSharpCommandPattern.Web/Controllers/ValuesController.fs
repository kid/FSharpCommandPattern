namespace FSharpCommandPattern.Web.Controllers

open System
open System.Linq
open System.Net.Http
open System.Web.Http
open FSharpCommandPattern.Domain
open FSharpCommandPattern.Domain.CommandHandler

/// Retrieves values.
[<RoutePrefix("api2/values")>]
type ValuesController() =
    inherit ApiController()
    let values = [| "value1"; "value2" |]

    /// Gets all values.
    [<Route("")>]
    member x.Get() = values

    /// Gets the value with index id.
    [<Route("{id:int}")>]
    member x.Get(id) : IHttpActionResult =
        handle' (PauseSurvey(1, "foo"))
        if id > values.Length - 1 then x.BadRequest() :> _
        else x.Ok(values.[id]) :> _

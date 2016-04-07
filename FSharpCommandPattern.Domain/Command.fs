namespace FSharpCommandPattern.Domain

module Command =
    type UserId = string

    type ICommand =
        abstract member UserId: UserId

    type Command(userId) =
        interface ICommand with
            member this.UserId = userId

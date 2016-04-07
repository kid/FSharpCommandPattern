namespace FSharpCommandPattern.Domain

open Command
open CommandHandler

type PauseSurvey(surveyId : int, userId) =
    inherit Command(userId)
    member this.SurveyId = surveyId

type ResumeSurvey(surveyId, userId) =
    inherit Command(userId)
    member this.SurveyId = surveyId

type SurveyCommandsHandler =
    interface ICommandHandler<PauseSurvey> with
        member this.Handle(command : PauseSurvey) = ()

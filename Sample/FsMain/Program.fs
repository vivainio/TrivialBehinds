open System
open System.Windows.Forms
open DesignerPart
open TrivialBehind

type MyBehind(ui: CalcUi) =
    let mutable counter = 0
    let showCount() =
        ui.label1.Text <- sprintf "Count is: %d" counter

    do
        ui.btnPlus.Click.Add <|
            fun _ ->
                counter <- counter+1
                showCount()
        ui.btnMinus.Click.Add <|
            fun _ ->
                counter <- counter-1
                showCount()


let registerAppBehinds() =
    TrivialBehinds.RegisterBehind<CalcUi, MyBehind>()
    

[<EntryPoint; STAThread>]
let main argv =
    registerAppBehinds()
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(false)
    use form = new Form1();
    Application.Run(form)
    0

open System
open System.Windows.Forms
open DesignerPart
open TrivialBehind

type Form1Behind(ui: Form1Ui) =
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
        ui.btnLaunchDirect.Click.Add <|
            fun _ ->
                let f2 = new DirectForm()
                f2.Show()


// example without separate UI class
type DirectBehind(ui: DirectForm) = 
    do 
        ui.label1.Text <- "Direct form initialized"
    
type UserControlBehind(ctrl: UserControl1) = 
    do        
        ()
    



let registerAppBehinds() =
    TrivialBehinds.RegisterBehind<Form1Ui, Form1Behind>()
    TrivialBehinds.RegisterBehind<DirectForm, DirectBehind>()
    TrivialBehinds.RegisterBehind<UserControl1, UserControlBehind>()

[<EntryPoint; STAThread>]
let main argv =
    registerAppBehinds()
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(false)
    use form = new Form1();
    Application.Run(form)
    0

(**
## This is my first page
*)

printfn "Stock prices download example:\n"
(***include-fsi-output***)

#loar "YahooFinance.fsx"

open YahooFinance

let vti = YahooFinance.PriceHistory("vti") // 

#r "nuget: Ploty.NET, 2.0.0-preview.17"

open Ploty.NativeInterop

vti|> List.map(fun x -> x-x.Date, x.AdjustedClose)
|> Chart.Line
|> GenericChart.toChartHTML

(***include***)
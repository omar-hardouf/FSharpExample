(**
## This is my first page
*)

printfn "Stock prices download example:"
(***include-fsi-output***)

printfn "Stock prices download example:"
(***include-it-raw***)

#load "YahooFinance.fsx"

open YahooFinance

let vti = YahooFinance.PriceHistory("vti") // 

#r "nuget: Plotly.NET, 2.0.0-preview.17"

open Plotly.NET

vti
|> List.map(fun x -> x.Date, x.AdjustedClose)
|> Chart.Line
|> GenericChart.toChartHTML

(***include-it-raw***)
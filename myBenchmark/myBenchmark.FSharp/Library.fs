namespace myBenchmark

module FSharp =
    open System

    type [<Struct>] Range =
        private { Start : int 
                  End : int }

    module Range =
        let create s e =
            if (s < 1 || e < 0) && e <= s then
                failwithf "The interval [start,end] given is incorrect : [%i,%i]" s e
            else
                { Start = s ; End = e }

    type FizzBuzzImplementations(_fizzBuzzLogic:Func<int,string>) =
        let fizzBuzzLogic number =
            _fizzBuzzLogic.Invoke(number)
            
        member __.imperativeForLoopVersion range  =
            let mutable results = List.empty<string>
            for number = range.Start to range.End do
                results <- [ fizzBuzzLogic number ] |> List.append results
            results |> Array.ofList

        member __.imperativeForLoopVersionWithArrayInitialization range =
            let results = Array.init range.End (fun _ -> "")
            for number = range.Start to range.End do
                let index = number - 1
                results.[index] <- fizzBuzzLogic number
            results
        
        member __.recursiveStyle range =
            let rec doTheFizzBuzz number max =
                match number = max with
                | true -> fizzBuzzLogic number :: []
                | false -> fizzBuzzLogic number :: doTheFizzBuzz (number + 1) max
            doTheFizzBuzz range.Start range.End |> Array.ofList

        member __.recursiveStyleTailCallOptimized range =
            let rec doTheFizzBuzz number max fAcc =
                match number = max with
                | true -> fAcc number
                | false -> doTheFizzBuzz (number + 1) max (fun z -> fizzBuzzLogic number :: fAcc z)
            doTheFizzBuzz range.Start range.End (fun z -> fizzBuzzLogic z :: []) |> Array.ofList

        member __.mappingStyle range =
            [|range.Start .. range.End|] |> Array.map fizzBuzzLogic

        member __.parallelMappingStyle range =
            [| range.Start .. range.End |] |> Array.Parallel.map fizzBuzzLogic
        

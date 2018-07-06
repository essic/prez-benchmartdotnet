namespace myBenchmark.Runner.Test
open System
open Xunit
open Swensen.Unquote
open myBenchmark.Runner

module Test =

    let fizzBuzzLogic = Func<int,string>( fun i -> FizzBuzzLogic.Execute(i))

    module VerifyFizzBuzzLogic =
        open Hedgehog

        [<Fact>]
        let ``FizzBuzzLogic should always returns Buzz here`` () =
            property {
                let! number = Gen.int (Range.constantBounded())
                where ((number % 5) = 0)
                where ((number % 3) <> 0)
                test<@ fizzBuzzLogic.Invoke(number) = "Buzz" @>
            } |> Property.check' 10<tests>
    
        [<Fact>]
        let ``FizzBuzzLogic should always returns Fizz here`` () =
            property {
                let! number = Gen.int (Range.constantBounded())
                where ((number % 5) <> 0)
                where ((number % 3) = 0)
                test<@ fizzBuzzLogic.Invoke(number) = "Fizz" @>
            } |> Property.check' 10<tests>

        [<Fact>]
        let ``FizzBuzzLogic should always returns 'number' given here``() =
            property {
                let! number = Gen.int (Range.constantBounded())
                where ((number % 5) <> 0)
                where ((number % 3) <> 0)
                test<@ fizzBuzzLogic.Invoke(number) = (sprintf "%i" number) @>
            } |> Property.check' 10<tests>

    module VerifyFSharpImplementation =
        open myBenchmark.FSharp

        let subject = FizzBuzzImplementations(fizzBuzzLogic)   
        let givenRange = Range.create 1 100

        let processOrderTest ( f : Range -> string[] ) =
            let shouldBeTrueIfTheOrderOfElementHasBeenPreserved =
                f givenRange
                |> Array.mapi 
                    (fun index value -> 
                        fizzBuzzLogic.Invoke(index + 1) = value
                    )
                |> Array.reduce (&&)
            shouldBeTrueIfTheOrderOfElementHasBeenPreserved

        [<Fact>]
        let ``Order is respected for the 'imperativeForLoopVersion' method``() =
            test <@ processOrderTest subject.imperativeForLoopVersion = true @>

        [<Fact>]
        let ``Order is respected for the 'imperativeForLoopVersionWithArrayInitialization' method`` () =
            test <@ processOrderTest subject.imperativeForLoopVersionWithArrayInitialization = true @>
    
        [<Fact>]
        let ``Order is respected for the 'mappingStyle' method`` () =
            test <@ processOrderTest subject.mappingStyle = true @>
    
        [<Fact>]
        let ``Order is respected for the 'parallelMappingStyle' method`` () =
            test <@ processOrderTest subject.parallelMappingStyle = true @>

        [<Fact>]
        let ``Order is respected for the 'recursiveStyle' method`` () =
            test <@ processOrderTest subject.recursiveStyle = true @>
    
        [<Fact>]
        let ``Order is respected for the 'recursiveStyleTailCallOptimized' method`` () =
            test <@ processOrderTest subject.recursiveStyleTailCallOptimized = true @>

    module VerifyCSharpImplementation =
    
        open myBenchmark.CSharp

        let givenRange = Range(1,100)
        let subject = FizzImplementations(fizzBuzzLogic)

        let processOrderTest ( f : Range -> string[] ) =
            let shouldBeTrueIfTheOrderOfElementHasBeenPreserved =
                f givenRange
                |> Array.mapi 
                    (fun index value -> 
                        fizzBuzzLogic.Invoke(index + 1) = value
                    )
                |> Array.reduce (&&)
            shouldBeTrueIfTheOrderOfElementHasBeenPreserved

        [<Fact>]
        let ``Order is respected for the 'BasicForLoopVersion' method`` () =
            test <@ processOrderTest subject.BasicForLoopVersion = true @>
        
        [<Fact>]
        let ``Order is respected for the 'ForLoopWithAnInitializedArrayVersion' method`` () =
            test <@ processOrderTest subject.ForLoopWithAnInitializedArrayVersion = true @>

        [<Fact>]
        let ``Order is respected for the 'LinqVersion' method`` () =
            test <@ processOrderTest subject.LinqVersion = true @>

        [<Fact>]
        let ``Order is respected for the 'ParallelLinqVersion' method`` () =
            test <@ processOrderTest subject.ParallelLinqVersion = true @>
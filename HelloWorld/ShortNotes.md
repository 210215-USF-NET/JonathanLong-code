CLR (Common language Runtime)
    - Runtime that manages a bunch of stuff, garbage collection, ect
    - JIT (Just in Time) Compiler 
        - Takes in code, compiles it from intermediate language to machine code, the machine can then run your code 
obj, bin folders
    - build output 
    - result of running dotnet build
dotnet run
    - dotnet build + run the code 
dotnet build
    - compiles code 

TLDRR compilation process:
.cs file  > compiled using MSBUILD > IL (Intermediate Language) > CLR (common language runtime) processed by JIT >machine code 
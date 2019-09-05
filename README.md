# Setup Unitest for project

# Create solution
   mkdir dotnet-unitest
   cd dotnet-unitest/
   dotnet new sln
   
# Create Project
   mkdir PrimeService
   cd PrimeService/
   dotnet new classlib
   mv Class1.cs PrimeService.cs
   vim PrimeService.cs

## add Project into solution
   dotnet sln add PrimeService/PrimeService.csproj
   
# Create Test project
   mkdir PrimeService.Tests
   cd PrimeService.Tests
   dotnet new nunit
   mv UnitTest1.cs PrimeServiceTest.cs
   dotnet add reference ../PrimeService/PrimeService.csproj

## add Test project into solution
   cd ../dotnet-unitest
   dotnet sln add ./PrimeService.Tests/PrimeService.Tests.csproj
   
## edit code
   vim PrimeService.Tests/PrimeServiceTest.cs

```
using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            throw new NotImplementedException("Please create a test first.");
        }
    }
} 
```
   
   vim PrimeService/PrimeService.cs

```
using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            PrimeService primeService = CreatePrimeService();
            var result = primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
        
        /*
        More tests
        */
        
        private PrimeService CreatePrimeService()
        {
             return new PrimeService();
        }
    }
}

```
   
# run unittest
   cd PrimeService.Tests/
   dotnet test

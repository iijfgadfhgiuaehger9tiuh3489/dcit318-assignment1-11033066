# DCIT 318 Assignment 1 - Console Applications

**Student ID: 11033066**

This repository contains three C# console applications created for DCIT 318 Assignment 1.

## Applications

### 1. Grade Calculator

**Location**: `GradeCalculator/GradeCalculator.cs`

A program that converts numerical grades (0-100) to letter grades:

- 90 and above: A
- 80-89: B
- 70-79: C
- 60-69: D
- Below 60: F

**Features**:

- Input validation for grade range
- Error handling for invalid inputs
- Clear user feedback

### 2. Ticket Price Calculator

**Location**: `TicketPriceCalculator/TicketPriceCalculator.cs`

A movie theater ticket pricing system:

- Regular price: GHC10
- Discounted price (Children ≤12 or Seniors ≥65): GHC7

**Features**:

- Age-based pricing calculation
- Category identification
- Input validation and error handling

### 3. Triangle Type Identifier

**Location**: `TriangleTypeIdentifier/TriangleTypeIdentifier.cs`

A program that identifies triangle types based on side lengths:

- **Equilateral**: All three sides are equal
- **Isosceles**: Two sides are equal
- **Scalene**: No sides are equal

**Features**:

- Triangle validity checking (triangle inequality theorem)
- Input validation for positive numbers
- Comprehensive error handling

## How to Run

Since the .NET SDK is not installed, you can compile and run these applications using the C# compiler:

```powershell
# Navigate to the application folder
cd GradeCalculator

# Compile the program
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe GradeCalculator.cs

# Run the executable
.\GradeCalculator.exe
```

Repeat the same process for the other applications:

- **TicketPriceCalculator**: `cd TicketPriceCalculator` → compile → `.\TicketPriceCalculator.exe`
- **TriangleTypeIdentifier**: `cd TriangleTypeIdentifier` → compile → `.\TriangleTypeIdentifier.exe`

All applications have been successfully compiled and tested!

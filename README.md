```markdown
# ✅ Validation Service – C# Input Validation Library

A lightweight **Validation Service** built with **C#** that helps developers validate user input and application data before processing or storing it.

This service centralizes validation logic in one place, making applications **cleaner, safer, and easier to maintain**. It can be integrated into **Console Applications, Windows Forms, Web APIs, or other .NET projects**.

---

## 🚀 Features

- Centralized validation logic
- Reusable validation methods
- Simple and clean structure
- Reduces repetitive validation code
- Easy integration with any C# project
- Supports common validation scenarios

---

## 🛠️ Technologies Used

- **C#**
- **.NET Framework / .NET**
- **Object-Oriented Programming (OOP)**

---

## 📂 Project Structure

```

ValidationService
│
├── Program.cs
├── Services
│   └── ValidationService.cs
│
├── Models
│   └── User.cs
│
└── README.md

````

---

## ⚙️ How It Works

The **Validation Service** contains methods that check if the provided data meets specific conditions such as:

- Required fields
- Minimum length
- Email format validation
- Numeric validation

Instead of writing validation logic multiple times, the application calls the **ValidationService methods**.

---

## 💻 Example Implementation

### Validation Service

```csharp
using System;
using System.Text.RegularExpressions;

public class ValidationService
{
    public bool IsRequired(string value)
    {
        return !string.IsNullOrWhiteSpace(value);
    }

    public bool MinLength(string value, int length)
    {
        return value.Length >= length;
    }

    public bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }

    public bool IsNumber(string value)
    {
        return int.TryParse(value, out _);
    }
}
````

---

### Example Usage

```csharp
class Program
{
    static void Main()
    {
        ValidationService validator = new ValidationService();

        string email = "example@mail.com";

        if (validator.IsRequired(email) && validator.IsValidEmail(email))
        {
            Console.WriteLine("Valid email address.");
        }
        else
        {
            Console.WriteLine("Invalid email address.");
        }
    }
}
```

---

## 📦 Installation

Clone the repository:

```
git clone https://github.com/yourusername/validation-service.git
```

Then:

1. Open the project in **Visual Studio**
2. Build the solution
3. Run the project

---

## 🎯 Purpose

The purpose of this project is to demonstrate how to build a **reusable validation layer** in C# applications.
By separating validation logic into a dedicated service, developers can keep their code **organized, scalable, and easier to maintain**.

---

## 🤝 Contributing

Contributions, suggestions, and improvements are welcome.
Feel free to fork the repository and submit a pull request.

```
```

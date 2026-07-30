# ⚡ Electricity Bill Estimator

A menu-driven C# .NET Console Application that calculates an electricity bill based on the number of units consumed and the cost per unit. The application demonstrates the fundamentals of Object-Oriented Programming (OOP) by separating data models, business logic, input validation, and user interface into different classes.

## 📌 Features

- Calculate electricity bill
- View bill summary
- Clear current bill data
- Exit the application
- Input validation for numeric values
- Menu-driven console interface

---

## 🛠️ Technologies Used

- C#
- .NET Console Application
- Object-Oriented Programming (OOP)

---

## 📂 Project Structure

```
ElectricityBillEstimator/
│
├── Models/
│   └── Bill.cs
│
├── Services/
│   ├── BillCalculator.cs
│   └── InputValidator.cs
│
├── UI/
│   └── Menu.cs
│
└── Program.cs
```

---

## 📖 Business Rules

The application calculates the electricity bill using the following formula:

```
Total Bill = Units Consumed × Cost Per Unit
```

The application validates:

- Units consumed cannot be negative.
- Cost per unit must be greater than zero.
- Invalid inputs do not terminate the application.

---

## ▶️ How to Run

1. Clone the repository.

```bash
git clone https://github.com/your-username/ElectricityBillEstimator.git
```

2. Open the project in Visual Studio.

3. Build and run the application.

---

## 📷 Sample Output

```
====================================
     ELECTRICITY BILL ESTIMATOR
====================================

1. Calculate Bill
2. View Bill Summary
3. Clear Current Input
4. Exit

Enter your choice:
```

---

## OOP Concepts Demonstrated

- Classes and Objects
- Properties
- Methods
- Object Composition
- Separation of Concerns
- Input Validation
- Menu-Driven Console Applications

---

## Learning Outcomes

Through this project, I practiced:

- Building a structured console application in C#
- Applying Object-Oriented Programming principles
- Organizing code into Models, Services, and UI layers
- Validating user input
- Performing business logic separately from user interaction
- Creating a clean and maintainable project structure

---


## Outputs
Test Case 1 : Choosing to display bill and clear bill before entering details
<img width="454" height="487" alt="image" src="https://github.com/user-attachments/assets/2eca9395-a158-4ee3-9a78-733639030df8" />

Test Case 2 : Entering invalid input for 'units consumed' and 'rate per unit' fields
<img width="478" height="665" alt="image" src="https://github.com/user-attachments/assets/17df5e0c-59c8-4aca-88c6-f3c471efca9c" />

Test Case 3 : Valid input and printing the bill on the console
<img width="505" height="939" alt="image" src="https://github.com/user-attachments/assets/040dfb5c-a246-4f4d-ab5a-d7b8288a98cc" />


## 👨‍💻 Author

**Megha S**

B.Tech Computer Science Engineering

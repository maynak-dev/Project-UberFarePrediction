# 🚖 Uber Fare Prediction (ML.NET + .NET 9 Console App)

## 📌 Overview
This project predicts Uber fares based on ride details such as pickup/dropoff locations, passenger count, and pickup time.  
It uses **ML.NET** in **.NET 9** with a pre-trained regression model.

- **Tech Stack**: C#, .NET 9, ML.NET
- **Model Type**: Regression
- **Training Data**: Uber rides dataset (CSV)
- **Output**: Predicted fare amount

---

## 📊 How It Works
1. **Training**:  
   The model was trained using [Kaggle’s Uber dataset](https://www.kaggle.com) in ML.NET Model Builder.
   
2. **Features Used**:
   - Pickup Latitude & Longitude
   - Dropoff Latitude & Longitude
   - Passenger Count
   - Pickup Date & Time

3. **Prediction**:  
   User inputs trip details into the console app, and the app returns the predicted fare.

---

## 📂 Project Structure
UberFarePrediction.sln
│
├── MLModel1_ConsoleApp1/ # Auto-generated ML.NET model project
│ ├── MLModel1.cs # Model input/output classes & Predict() method
│ ├── Program.cs # Sample usage (auto-generated)
│ └── UberFareModel.zip # Saved trained model
│
├── UberFarePrediction/ # Main interactive console app
│ ├── Program.cs # Takes user input & predicts fare
│
└── README.md # Project documentation

**##yaml**

## ⚙️ Installation & Usage
### 1️⃣ Clone the Repository
```bash
git clone https://github.com/yourusername/UberFarePrediction.git
cd UberFarePrediction

**📦##Requirements**
.NET 9 SDK
Visual Studio 2022+
ML.NET Model Builder

🙌 **Contributing**:
Pull requests are welcome!
If you find a bug or have a feature request, please open an issue.


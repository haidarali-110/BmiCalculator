# BMI Calculator — ASP.NET Core

A simple, user-friendly Body Mass Index (BMI) calculator web app built with **ASP.NET Core Razor Pages**.

The app takes **Age**, **Gender**, **Height (cm)**, and **Weight (kg)** as input, calculates BMI, and classifies the result using the standard BMI table.


## Classification Table

classification of bmi range  :

savere Thinness < 16 
Moderate Thinness 16 -17 
mild Thinness 17 – 18.5 
Normal 18.5 – 25
overweight 25 -30
obese  class 1 30 - 35
obese  class 2 35 – 40 
obese  class 3 > 40 





### Run the app

```bash
git clone https://github.com/haidarali-110/BmiCalculator.git
cd BmiCalculator
dotnet restore
dotnet run
```


## Docker Documentation


### 1. Pull a Docker image

```bash
docker pull hello-world
```

### 2. Run the image as a container

```bash
docker run --name demo-container hello-world
```

### 3. Create a container from the image 

```bash
docker create --name demo-container hello-world
```

```bash
docker start demo-container
```

### 4. Stop a running container

```bash
docker stop demo-container
```

### Other useful Docker commands

```bash
docker ps                    
docker ps -a                
docker images                
docker rm demo-container      
docker rmi hello-world        
```


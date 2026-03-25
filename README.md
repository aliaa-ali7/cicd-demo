# CI/CD Demo - ASP.NET Core

![CI Pipeline](https://github.com/aliaa-ali7/cicd-demo/actions/workflows/ci.yml/badge.svg)

## About
A simple ASP.NET Core Web API with a fully automated CI pipeline using GitHub Actions.

## CI/CD Pipeline
Every push to this repository automatically:
- ✅ Restores dependencies
- ✅ Builds the project
- ✅ Runs unit tests

## Tech Stack
- ASP.NET Core 10
- xUnit (Unit Testing)
- GitHub Actions (CI/CD)

## How to Run
```bash
dotnet restore
dotnet build
dotnet test
```
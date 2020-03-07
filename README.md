# _Word Counter_

#### _Epicodus 2020 C#/React Cohort Intermediate C# and Testing Friday Project._

#### By _**Geoff Goetz | 6 March 2020**_

## Description

This project will allow a user to enter a word and a sentence. From that input check how frequently the input word appears in the input sentence.

## Project Specifications

| Behavior | Input | Output |
|:---:|:---:|:---:|
| User input a single word to be counted  | magic | Magic will be counted |
| Input Sentence will be broken down into array of words | Magical magicians doing magic | {"Magical", "magicians", "doing", "magic"} |
| Input Sentence array of words will be made all lower case | {"Magical", "magicians", "doing", "magic"} | {"magical", "magicians", "doing", "magic"} |
| User input a sentence or phrase to check for the previously entered word | The art of magic and magicians | magic appears 1 time in this sentence |


## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/Pieharder/Word-Counter```
* Open file in your preferred text editor
* On Mac: ```open -a {your text editor} Word-Counter.Solution```
* On Windows: ```Word-Counter.Solution```

_Download Manually:_

* Navigate to https://github.com/Pieharder/Word-Counter.
* Click the green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder called "Anagram.Solution".

_Note For Editors:_ 
* Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal
* Install dotnet script, run the ```$ dotnet tool install -g dotnet-script``` command in your terminal
* Restart your terminal to complete installation, and run then navigate into your test directory and run  ```$ dotnet restore ``` command to run application within your terminal.
* Following this, from the test directory, run ```$ dotnet test ``` to run all tests.

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/Pieharder/Word-Counter/issues) here on GitHub._

## Technologies Used

* VS Code
* C#
* .Net Core
* MSTest
* MSTest Template Generator by Patrick Kille & Dusty McCord

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Geoff Goetz_**
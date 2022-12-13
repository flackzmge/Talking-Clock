# Talking Clock C# Console application

A C# Console application that converts a given time in hour and minute format to a talking clock format. The application includes the following public methods:

```
MinsToText(int min): Converts the given minute value to its corresponding text value. For example, MinsToText(15) returns "fifteen".
HourToText(int hour, bool isPast30 = false): Converts the given hour value to its corresponding text value. If the isPast30 parameter is set to true, the hour will be converted to the past 30 format. For example, HourToText(3, true) returns "two thirty".
GetTalkingTimeNow(): Returns the current time in talking clock format.
GetTalkingTime(string time): Takes a time value in string format (e.g. "12:30") and returns it in talking clock format.
OutputTalkingTime(int hour, int minutes): Takes hour and minute values and returns the time in talking clock format.
```
## Talking Clock API

In addition to the C# Console application, this project includes a Talking Clock API that returns the current time in talking clock format as a JSON object. The API includes unit tests to ensure proper functionality.

## Usage

To use the C# Console application, clone this repository and open the solution file in Visual Studio. Build and run the application, and use the provided public methods to convert time values to talking clock format.

To use the Talking Clock API, make a GET request to the /api/talkingclock endpoint. The response will be a JSON object containing the current time in talking clock format.

## Contributing

To contribute to this project, fork the repository and create a pull request with your changes. Please include a detailed description of your changes and any relevant testing in your pull request.

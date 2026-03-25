# Serial Communication with PLC - C# Example

This is an example of how the SerialPort library can be used to communicate with PLCs via an RS485 connection. This only works on Windows.

## Prerequisites

Install Visual Studio 2022 or later (Community Edition works). Use NuGet Package Manager to install the SerialPort dependency.

## Usage
1. Open the solution file in Visual Studio, then build and run
2. Set your serial parameters (COM Port, baud rate, etc) as appropriate for your PLC
3. Click the `Open Port` button to establish the serial communication
4. Enter a command in the text field and press Enter. The response will display in the output text box underneath.

## Notes
* If you wish to send [Hostlink](https://docs.triplc.com/hostlink/) commands to a Triangle Research PLC like the WX100, you need to format your commands for the [multi-point](https://docs.triplc.com/um/wx100-users-manual/chapter-11-20/wx100-chapter-15/15-2/) protocol. Every command must begin with an `@` character.

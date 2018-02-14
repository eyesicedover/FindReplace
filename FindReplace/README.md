
# Rock Paper Scissors

#### By Cameron Anderson & Stephanie Faber

## Description
Takes an input text, a string to find, and a string to replace it with. Replaces all instances of the first string with the second.

## Specifications
* Take input from the user
- example input:
  - Text: "A very very long piece of text"
  - String to find: "very"
  - String to replace: "super"

* Identify the indices of each occurrence of the string to find in the text.
- example input:
  - Text: "A very very long piece of text"
  - String to find: "very"
- example output:
  - 2, 7

* Reconstruct the text around each occurrence of the found string replacing it with the replacement string.
- example input:
  - Text: "A very very long piece of text"
  - String to find: "very"
  - String to replace: "super"
- example output:
  - "A super super long piece of text"

* Display the reconstructed text to the view.




## Setup/Installation Requirements

* Clone the git repository from 'https://github.com/camander321/FindReplace.git'.
* run the command 'dotnet restore' to download the necessary packages.
* run the command 'dotnet run' to build and run the server on localhost.
* use your preferred web browser to navigate to localhost:5000


## Support and contact details

* contact the author at chamburg321@gmail.com

## Technologies Used

* C#
* Asp .NET Core MVC
* HTML
* CSS
* Javascript
* Bootstrap
* JQuery

### License

Copyright (c) 2018 Cameron Anderson & Stephanie Faber

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.



Imports System.Runtime.CompilerServices
Public Module StringExtensions

  <Extension()>
  Public Function ToTitleCase(ByVal candidate As String) As String

    Return Globalization.CultureInfo.CurrentCulture.
              TextInfo.ToTitleCase(candidate.ToLower())
  End Function

End Module


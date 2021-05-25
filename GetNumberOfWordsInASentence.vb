Public Function GetNumberOfWords(ByVal Sentence As String) As Integer
  Return Sentence.Split(New Char() {" "}).Length
End Function

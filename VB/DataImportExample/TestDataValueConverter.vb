Imports DevExpress.Drawing
Imports System.Runtime.InteropServices

Namespace DataImportExample

#Region "#converter"
    Friend Class TestDataValueConverter
        Implements DevExpress.Spreadsheet.IDataValueConverter

        Public Function TryConvert(ByVal value As Object, ByVal columnIndex As Integer, <Out> ByRef result As DevExpress.Spreadsheet.CellValue) As Boolean Implements DevExpress.Spreadsheet.IDataValueConverter.TryConvert
             ''' Cannot convert SwitchStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.CaseClauseSyntax'.
'''    at System.Linq.Enumerable.<CastIterator>d__97`1.MoveNext()
'''    at Microsoft.CodeAnalysis.VisualBasic.SyntaxFactory.SeparatedList[TNode](IEnumerable`1 nodes)
'''    at ICSharpCode.CodeConverter.VB.MethodBodyExecutableStatementVisitor.ConvertSwitchSection(SwitchSectionSyntax section)
'''    at System.Linq.Enumerable.WhereSelectEnumerableIterator`2.MoveNext()
'''    at System.Linq.Buffer`1..ctor(IEnumerable`1 source)
'''    at System.Linq.Enumerable.ToArray[TSource](IEnumerable`1 source)
'''    at ICSharpCode.CodeConverter.VB.MethodBodyExecutableStatementVisitor.VisitSwitchStatement(SwitchStatementSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)
''' 
''' Input:
'''             switch (value)
'''             {
'''                 case string strValue:
'''                     try
'''                     {
'''                         result = DevExpress.Drawing.DXImage.FromBase64String(strValue);
'''                     }
'''                     catch
'''                     {
'''                         int str2int = 0;
'''                         if (System.Int32.TryParse(strValue, out str2int))
'''                         {
'''                             result = str2int;
'''                         }
'''                         else
'''                         {
'''                             result = strValue;
'''                         }
'''                     }
'''                     return true;
'''                 case int intValue:
'''                     result = intValue;
'''                     return true;
'''                 case bool boolValue:
'''                     result = boolValue;
'''                     return true;
'''                 default:
'''                     result = value == null ? null : value.ToString();
'''                     return true;
'''             }
''' 
'''  End Function
    End Class
#End Region  ' #converter
End Namespace

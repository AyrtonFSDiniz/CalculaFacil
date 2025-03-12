using OfficeOpenXml;

public class Excel
{
    public MemoryStream? GerarExcel<T>(List<T> dados){

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        var stream = new MemoryStream();
        using (ExcelPackage package = new ExcelPackage(stream)){

            var workSheet = package.Workbook.Worksheets.Add("Dados");

            workSheet.Cells.LoadFromCollection<T>(dados, true);

            for(int linha = 2; linha <= workSheet.Dimension.End.Row; linha++){
                for(int coluna = 1; coluna <= workSheet.Dimension.End.Column; coluna ++){
                    var celula = workSheet.Cells[linha, coluna];
                    if(celula.Value is DateTime){
                        celula.Value = ((DateTime)celula.Value).ToString("dd/MM/yyyy HH:mm:ss");
                    }
                }
            }

            var streamData = new MemoryStream(package.GetAsByteArray());

            return streamData;
        };
    }
}

<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<List<MvcCamion.Models.Camion>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<body>
      <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

        <table>
        <tr>
            <th></th>
            <th>
                IdCamion
            </th>
            <th>
                Descripcion
            </th>

        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new {  id=item.IdCamion }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.IdCamion })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.IdCamion })%>
            </td>
            <td>
                <%: item.IdCamion %>
            </td>
            <td>
                <%: item.Descripcion %>
            </td>
        </tr>
    
    <% } %>

    </table>

</body>
</html>

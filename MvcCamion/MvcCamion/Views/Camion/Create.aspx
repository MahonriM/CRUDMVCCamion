<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcCamion.Models.Camion>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Create</title>
</head>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<body>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IdCamion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IdCamion) %>
                <%: Html.ValidationMessageFor(model => model.IdCamion) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Descripcion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Descripcion) %>
                <%: Html.ValidationMessageFor(model => model.Descripcion) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Placa) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Placa) %>
                <%: Html.ValidationMessageFor(model => model.Placa) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Marca) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Marca) %>
                <%: Html.ValidationMessageFor(model => model.Marca) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Modelo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Modelo) %>
                <%: Html.ValidationMessageFor(model => model.Modelo) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    
</body>
</html>


﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcCamion.Models.Camion>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Details</title>
</head>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<body>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">IdCamion</div>
        <div class="display-field"><%:
         Model.IdCamion %>
         </div>
        
        <div class="display-label">Descripcion</div>
        <div class="display-field"><%: Model.Descripcion %></div>
        
        <div class="display-label">Placa</div>
        <div class="display-field"><%: Model.Placa %></div>
        
        <div class="display-label">Marca</div>
        <div class="display-field"><%: Model.Marca %></div>
        
        <div class="display-label">Modelo</div>
        <div class="display-field"><%: Model.Modelo %></div>
        
   <%:Html.ActionLink("Regresar","Index") %>
    </fieldset>
    

</body>
</html>


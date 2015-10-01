<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NextDrives.aspx.cs" Inherits="CAB_Management_System.CabManagement.NextDrives" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script type = "text/javascript">

         function Check_Click(objRef) {

             //Get the Row based on checkbox
             var row = objRef.parentNode.parentNode;
             if (objRef.checked) {
                 //If checked change color to Aqua
                 //row.style.backgroundColor = "aqua";
             }
             else {
                 //If not checked change back to original color
                 if (row.rowIndex % 2 == 0) {
                     //Alternating Row Color
                     row.style.backgroundColor = "#C2D69B";
                 }
                 else {
                     row.style.backgroundColor = "white";
                 }
             }

             //Get the reference of GridView
             var GridView = row.parentNode;

             //Get all input elements in Gridview
             var inputList = GridView.getElementsByTagName("input");

             for (var i = 0; i < inputList.length; i++) {
                 //The First element is the Header Checkbox
                 var headerCheckBox = inputList[0];

                 //Based on all or none checkboxes
                 //are checked check/uncheck Header Checkbox
                 var checked = true;

                 if (inputList[i].type == "checkbox" && inputList[i] != headerCheckBox) {
                     if (!inputList[i].checked) {
                         checked = false;
                         break;
                     }
                 }
             }
             headerCheckBox.checked = checked;
         }

         function checkAll(objRef) {

             var GridView = objRef.parentNode.parentNode.parentNode;
             var inputList = GridView.getElementsByTagName("input");
             for (var i = 0; i < inputList.length; i++) {
                 //Get the Cell To find out ColumnIndex
                 var row = inputList[i].parentNode.parentNode;
                 if (inputList[i].type == "checkbox" && objRef != inputList[i]) {
                     if (objRef.checked) {
                         //If the header checkbox is checked
                         //check all checkboxes
                         //and highlight all rows
                         //row.style.backgroundColor = "aqua";
                         inputList[i].checked = true;
                     }
                     else {
                         //If the header checkbox is checked
                         //uncheck all checkboxes
                         //and change rowcolor back to original 
                         //if (row.rowIndex % 2 == 0) {
                         //    //Alternating Row Color
                         //    row.style.backgroundColor = "#C2D69B";
                         //}
                         //else {
                         //    row.style.backgroundColor = "white";
                         //}
                         inputList[i].checked = false;

                     }
                 }
             }
         }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset id="fsDailyRequest" runat="server">
                <legend>Daily Request</legend>
                <asp:GridView ID="gvDailyResponse" runat="server" AutoGenerateColumns="false" Visible="false" Style="clear: both;" OnRowDeleting="OnDailyResponseRowDeleting" OnRowDataBound = "OnDailyResponseRowDataBound">
                    <Columns>
                        <asp:BoundField DataField="strRequestId" HeaderText="Request Id" />
                        <asp:BoundField DataField="strPickupDate" HeaderText="Pickup Date" />
                        <asp:BoundField DataField="strPickupTime" HeaderText="Pickup Time" />
                        <asp:BoundField DataField="strPickupLocation" HeaderText="Pickup Location" />
                        <asp:BoundField DataField="strDropDate" HeaderText="Drop Date" />
                        <asp:BoundField DataField="strDropTime" HeaderText="Drop Time" />
                        <asp:BoundField DataField="strDropLocation" HeaderText="Drop Location" />                        
                        <asp:CommandField ShowDeleteButton="True" HeaderText="Action" ButtonType="Button" />
                    </Columns>
                     <EmptyDataTemplate>
                         <div style="color:red;">
                        No Daily Cab request's Found!.
                             </div>
                    </EmptyDataTemplate>
                </asp:GridView>
            </fieldset>

            <fieldset id="fsWeeklyRequest" runat="server" style="margin-top:20px;">
                <legend>Weekly Request</legend>
                <asp:GridView ID="gvWeeklyResponse" runat="server" AutoGenerateColumns="false" Visible="false"  OnRowDataBound = "OnWeeklyResponseRowDataBound" OnRowDeleting="OnWeeklyResponseRowDeleting">
                    <Columns>
                        <asp:BoundField DataField="strRequestId" HeaderText="Request Id" />
                            <asp:BoundField DataField="strPickupDate" HeaderText="Pickup Date" />
                            <asp:BoundField DataField="strPickupLocation" HeaderText="Pickup Location" />
                            <asp:BoundField DataField="strPickupTime" HeaderText="Pickup Time" />
                             <asp:BoundField DataField="strDropDate" HeaderText="Drop Date" />
                            <asp:BoundField DataField="strDropLocation" HeaderText="Drop Location" />
                            <asp:BoundField DataField="strDropTime" HeaderText="Drop Time" />
                            <asp:BoundField DataField="strTripType" HeaderText="Trip Type" />
                         <asp:TemplateField HeaderText="Delete All">
                             <HeaderTemplate>                                 
                                 <asp:Button ID="btnDeleteAll" runat="server" CommandName="DeleteAll" Text="Delete All" />
                             </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Button ID="btnDelete" runat="server" CommandName="Delete" Text="Delete"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>

            </fieldset>

        </div>
    </form>
</body>
</html>

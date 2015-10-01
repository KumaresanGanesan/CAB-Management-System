<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="CAB_Management_System.CabManagement.History" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <div>
            <fieldset id="fsDailyRequest" runat="server">
                <legend>Daily Request</legend>
                <asp:GridView ID="gvDailyResponse" runat="server" AutoGenerateColumns="false" Visible="false" Style="clear: both;">
                    <Columns>
                        <asp:BoundField DataField="strRequestId" HeaderText="Request Id" />
                        <asp:BoundField DataField="strPickupDate" HeaderText="Pickup Date" />
                        <asp:BoundField DataField="strPickupTime" HeaderText="Pickup Time" />
                        <asp:BoundField DataField="strPickupLocation" HeaderText="Pickup Location" />
                        <asp:BoundField DataField="strDropDate" HeaderText="Drop Date" />
                        <asp:BoundField DataField="strDropTime" HeaderText="Drop Time" />
                        <asp:BoundField DataField="strDropLocation" HeaderText="Drop Location" />
                    </Columns>
                    <EmptyDataTemplate>
                        NO Daily Cab request's Found!.
                    </EmptyDataTemplate>
                </asp:GridView>
            </fieldset>

            <fieldset id="fsWeeklyRequest" runat="server" style="margin-top:20px;">
                <legend>Weekly Request</legend>
                <asp:GridView ID="gvWeeklyResponse" runat="server" AutoGenerateColumns="false" Visible="false">
                    <Columns>
                        <asp:BoundField DataField="strDate" HeaderText="Date" />
                        <asp:BoundField DataField="strPickupLocation" HeaderText="Pickup Location" />
                        <asp:BoundField DataField="strPickupTime" HeaderText="Pickup Time" />
                        <asp:BoundField DataField="strDropLocation" HeaderText="Drop Location" />
                        <asp:BoundField DataField="strDropTime" HeaderText="Drop Time" />
                        <asp:BoundField DataField="strTripType" HeaderText="Trip Type" />                        
                    </Columns>
                </asp:GridView>
            </fieldset>
        </div>
    </form>
</body>
</html>

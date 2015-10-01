<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CabRequest.aspx.cs" Inherits="CAB_Management_System.CabRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css" />

    <script src="//code.jquery.com/jquery-1.10.2.js"></script>
    <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <script>
        $(function () {
            $("#DropDate").datepicker();
            $("#PickupDate").datepicker();
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div>
            <table>
                <tr>
                    <td>Request Type : </td>
                    <td>
                        <asp:RadioButtonList ID="rdRequestType" runat="server" RepeatDirection="Horizontal" AutoPostBack="true" OnSelectedIndexChanged="rdRequestType_SelectedIndexChanged" >
                            <asp:ListItem Selected="True" Text="Daily" Value="0"></asp:ListItem>
                            <asp:ListItem Text="Weekly" Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>

            <table>
                    <tr>
                        <td>Travel Type : </td>                        
                        <td>
                            <asp:RadioButtonList ID="rdTravelType" runat="server" RepeatDirection="Horizontal" AutoPostBack="true" OnSelectedIndexChanged="rdTravelType_SelectedIndexChanged">
                                <asp:ListItem Text="Drop" Value="0" Selected="True"> </asp:ListItem>
                                <asp:ListItem Text="Pickup" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Both" Value="2"> </asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>

            <fieldset id="fsDailyRequest" runat="server">
                <legend>Daily Request</legend>                
                <div style="width: 100%">
                    <div id="divDrop" style="width: 50%; float: left" runat="server">
                        <fieldset id="fsDrop" runat="server">
                            <legend>Drop </legend>
                            <table>
                                <tr>
                                    <td>Drop Date : </td>
                                    <td>
                                        <input type="text" id="DropDate" /></td>
                                </tr>
                                <tr>
                                    <td>Time :  </td>
                                    <td>
                                        <asp:DropDownList ID="ddlDropTime" runat="server">
                                            <asp:ListItem Text="--Select--" Value="00"></asp:ListItem>
                                            <asp:ListItem Text="21:30" Value="0"></asp:ListItem>
                                            <asp:ListItem Text="22:30" Value="1"></asp:ListItem>
                                            <asp:ListItem Text="23:30" Value="2"></asp:ListItem>
                                            <asp:ListItem Text="00:30" Value="3"></asp:ListItem>
                                            <asp:ListItem Text="01:30" Value="4"></asp:ListItem>
                                            <asp:ListItem Text="02:30" Value="5"></asp:ListItem>
                                            <asp:ListItem Text="03:30" Value="6"></asp:ListItem>
                                            <asp:ListItem Text="04:30" Value="7"></asp:ListItem>
                                            <asp:ListItem Text="05:30" Value="8"></asp:ListItem>
                                            <asp:ListItem Text="06:30" Value="9"></asp:ListItem>
                                            <asp:ListItem Text="07:00" Value="10"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Drop Location : </td>
                                    <td>
                                        <input type="text" id="txtDropLocation" />
                                    </td>
                                </tr>

                            </table>
                        </fieldset>
                    </div>
                    <div id="divPickup" style="width: 50%; float: left" runat="server">
                        <fieldset id="fsPickup" runat="server">
                            <legend>Pickup</legend>
                            <table>
                                <tr>
                                    <td>Pickup Date : </td>
                                    <td>
                                        <input type="text" id="PickupDate" /></td>
                                </tr>
                                <tr>
                                    <td>Pickup Time :  </td>
                                    <td>
                                        <asp:DropDownList ID="ddlPickupTime" runat="server">
                                            <asp:ListItem Text="--Select--" Value="00"></asp:ListItem>
                                            <asp:ListItem Text="21:30" Value="0"></asp:ListItem>
                                            <asp:ListItem Text="22:30" Value="1"></asp:ListItem>
                                            <asp:ListItem Text="23:30" Value="2"></asp:ListItem>
                                            <asp:ListItem Text="00:30" Value="3"></asp:ListItem>
                                            <asp:ListItem Text="01:30" Value="4"></asp:ListItem>
                                            <asp:ListItem Text="02:30" Value="5"></asp:ListItem>
                                            <asp:ListItem Text="03:30" Value="6"></asp:ListItem>
                                            <asp:ListItem Text="04:30" Value="7"></asp:ListItem>
                                            <asp:ListItem Text="05:30" Value="8"></asp:ListItem>
                                            <asp:ListItem Text="06:30" Value="9"></asp:ListItem>
                                            <asp:ListItem Text="07:00" Value="10"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Pickup Location : </td>
                                    <td>
                                        <input type="text" id="txtPickLocation" />
                                    </td>
                                </tr>
                            </table>

                        </fieldset>
                    </div>
                </div>
               <div style="text-align: center; clear:both; padding-top:20px;">
                        <asp:Button ID="btnDailySave" runat="server" OnClick="btnDailySave_Click" Text="Save" />
                    </div>
                <div>
                    <asp:GridView ID="gvDailyResponse" runat="server" AutoGenerateColumns="false" Visible="false" style=" clear:both;">
                        <Columns>
                            <asp:BoundField DataField="strRequestId" HeaderText="Request Id"/>
                            <asp:BoundField DataField="strPickupDate" HeaderText="Pickup Date"/>
                            <asp:BoundField DataField="strPickupTime" HeaderText="Pickup Time"/>
                            <asp:BoundField DataField="strPickupLocation" HeaderText="Pickup Location"/>                            
                            <asp:BoundField DataField="strDropDate" HeaderText="Drop Date" />                            
                            <asp:BoundField DataField="strDropTime" HeaderText="Drop Time" />
                            <asp:BoundField DataField="strDropLocation" HeaderText="Drop Location" />
                        </Columns>
                    </asp:GridView>
                </div>
            </fieldset>

            <fieldset id="fsWeeklyRequest" runat="server">
                <legend>Weekly Request </legend>
                <div>
                    <asp:GridView ID="gvWeeklyRequest" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="strPickupDate" HeaderText="Pickup Date" />
                            <asp:TemplateField HeaderText="Pickup Time">
                                <ItemTemplate>
                                    <asp:DropDownList ID="ddlWeeklyPickupTime" runat="server">
                                        <asp:ListItem Text="--Select--" Value="00"></asp:ListItem>
                                        <asp:ListItem Text="21:30" Value="0"></asp:ListItem>
                                        <asp:ListItem Text="22:30" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="23:30" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="00:30" Value="3"></asp:ListItem>
                                        <asp:ListItem Text="01:30" Value="4"></asp:ListItem>
                                        <asp:ListItem Text="02:30" Value="5"></asp:ListItem>
                                        <asp:ListItem Text="03:30" Value="6"></asp:ListItem>
                                        <asp:ListItem Text="04:30" Value="7"></asp:ListItem>
                                        <asp:ListItem Text="05:30" Value="8"></asp:ListItem>
                                        <asp:ListItem Text="06:30" Value="9"></asp:ListItem>
                                        <asp:ListItem Text="07:00" Value="10"></asp:ListItem>
                                    </asp:DropDownList>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Pickup Location">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtPickupLocation" runat="server" Text='<%# Bind("PickupLocation") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                                                                               
                            <asp:BoundField DataField="strDropDate" HeaderText="Drop Date" />
                            <asp:TemplateField HeaderText="Drop Time">
                                <ItemTemplate>
                                    <asp:DropDownList ID="ddlWeeklyDropTime" runat="server">
                                        <asp:ListItem Text="--Select--" Value="00"></asp:ListItem>
                                        <asp:ListItem Text="21:30" Value="0"></asp:ListItem>
                                        <asp:ListItem Text="22:30" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="23:30" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="00:30" Value="3"></asp:ListItem>
                                        <asp:ListItem Text="01:30" Value="4"></asp:ListItem>
                                        <asp:ListItem Text="02:30" Value="5"></asp:ListItem>
                                        <asp:ListItem Text="03:30" Value="6"></asp:ListItem>
                                        <asp:ListItem Text="04:30" Value="7"></asp:ListItem>
                                        <asp:ListItem Text="05:30" Value="8"></asp:ListItem>
                                        <asp:ListItem Text="06:30" Value="9"></asp:ListItem>
                                        <asp:ListItem Text="07:00" Value="10"></asp:ListItem>
                                    </asp:DropDownList>
                                </ItemTemplate>
                            </asp:TemplateField> 
                            <asp:TemplateField HeaderText="Drop Location">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtDropLocation" runat="server" Text='<%# Bind("DropLocation") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                                                    
                            <asp:BoundField DataField="strReturnDate" HeaderText="Return Date" />
                             <asp:TemplateField HeaderText="Return Time">
                                <ItemTemplate>
                                    <asp:DropDownList ID="ddlWeeklyReturnTime" runat="server">
                                        <asp:ListItem Text="--Select--" Value="00"></asp:ListItem>
                                        <asp:ListItem Text="21:30" Value="0"></asp:ListItem>
                                        <asp:ListItem Text="22:30" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="23:30" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="00:30" Value="3"></asp:ListItem>
                                        <asp:ListItem Text="01:30" Value="4"></asp:ListItem>
                                        <asp:ListItem Text="02:30" Value="5"></asp:ListItem>
                                        <asp:ListItem Text="03:30" Value="6"></asp:ListItem>
                                        <asp:ListItem Text="04:30" Value="7"></asp:ListItem>
                                        <asp:ListItem Text="05:30" Value="8"></asp:ListItem>
                                        <asp:ListItem Text="06:30" Value="9"></asp:ListItem>
                                        <asp:ListItem Text="07:00" Value="10"></asp:ListItem>
                                    </asp:DropDownList>
                                </ItemTemplate>
                            </asp:TemplateField>  
                        </Columns>
                    </asp:GridView>

                    <div style="text-align: center; padding-top:20px;">
                        <asp:Button ID="btnWeeklySave" runat="server" OnClick="btnWeeklySave_Click" Text="Save" />
                    </div>

                    <asp:GridView ID="gvWeeklyResponse" runat="server" AutoGenerateColumns="false" Visible="false">
                        <Columns>
                            <asp:BoundField DataField="strRequestId" HeaderText="Request Id" />
                            <asp:BoundField DataField="strPickupDate" HeaderText="Pickup Date" />
                            <asp:BoundField DataField="strPickupTime" HeaderText="Pickup Time" />
                            <asp:BoundField DataField="strPickupLocation" HeaderText="Pickup Location" />                              
                            <asp:BoundField DataField="strDropDate" HeaderText="Drop Date" />                            
                            <asp:BoundField DataField="strDropTime" HeaderText="Drop Time" /> 
                            <asp:BoundField DataField="strDropLocation" HeaderText="Drop Location" />                         
                             <asp:BoundField DataField="strReturnDate" HeaderText="Return Date" />                            
                            <asp:BoundField DataField="strReturnTime" HeaderText="Return Time" />
                     
                        </Columns>
                    </asp:GridView>
                </div>
            </fieldset>

        </div>
</asp:Content>

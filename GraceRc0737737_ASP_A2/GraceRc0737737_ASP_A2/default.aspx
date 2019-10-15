<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="GraceRc0737737_ASP_A2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>This assignment id done by Grace Rapol</title>
</head>
<body>


    <div align="center">
        <img src="images/Lambton-College-800-x-600.jpg" height="300" width="500"  />
    </div>
   
    <div style="width: 1300px; background-color: #1E90FF";>
          <marquee direction="left"> Assignment 2 by Grace </marquee>
      </div>
     
    <form id="form1" runat="server">
        <div>
            <p>
            <asp:Label runat="server">Student Name : </asp:Label> 
            <asp:TextBox  ID="txtName"  runat="server" Width="200"> </asp:TextBox>
             </p>
        
        
             <p>
            <asp:Label runat="server">Student ID : </asp:Label> 
            <asp:TextBox  ID="txtID"  runat="server" Width="200"> </asp:TextBox>
             </p>

        </div>
         <div style="width: 1300px; background-color: #00BFFF";>
          <marquee direction="right"> Assignment Marks</marquee>
     </div>
    
        
            <p>
                <asp:Label runat="server"> Assignment 1: </asp:Label>
                <asp:TextBox  ID="txtA1"  runat="server" Width="200"> </asp:TextBox>

            </p>
            <p>
                <asp:Label runat="server"> Assignment 2: </asp:Label>
                <asp:TextBox  ID="txtA2"  runat="server" Width="200"> </asp:TextBox>

            </p>
        <p>
                <asp:Label runat="server"> Assignment 3: </asp:Label>
                <asp:TextBox  ID="txtA3"  runat="server" Width="200"> </asp:TextBox>

            </p>
        
            <p>
                <asp:Label runat="server"> Assignment 4: </asp:Label>
                <asp:TextBox  ID="txtA4"  runat="server" Width="200"> </asp:TextBox>

            </p>
        
            <p>
                <asp:Label runat="server"> Assignment 5: </asp:Label>
                <asp:TextBox  ID="txtA5"  runat="server" Width="200"> </asp:TextBox>

            </p>
        
        </div>
         <div style="width: 1300px; background-color: #00BFFF;">
          <marquee direction="left">Test Marks </marquee>
     </div>
        
            
               <p>
                <asp:Label runat="server"> Test 1: </asp:Label>
                <asp:TextBox  ID="txtT1"  runat="server" Width="200"> </asp:TextBox>

               </p>
            <p>
                <asp:Label runat="server"> Test 2: </asp:Label>
                <asp:TextBox  ID="txtT2"  runat="server" Width="200"> </asp:TextBox>

               </p>
        
            <p>
                <asp:Label runat="server"> Test 3: </asp:Label>
                <asp:TextBox  ID="txtT3"  runat="server" Width="200"> </asp:TextBox>

               </p>
        
        
        </div>
        <div>
            <p style="font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; background-color:lightskyblue; color:aliceblue;">
                <asp:Button ID="btnCalc" runat="server" Text="Calculate Grade" OnClick ="btnCalc_Click"/>
            </p>
        </div>
        <div>
            <p >
                 <asp:Label runat="server"> Course Total: </asp:Label>
                <asp:TextBox  ID="txtTotal"  runat="server" Width="200"> </asp:TextBox>
                <asp:Label runat="server"> Course Grade: </asp:Label>
                <asp:TextBox  ID="txtGrade"  runat="server" Width="200"> </asp:TextBox>
                <asp:Label runat="server">GPA : </asp:Label>
				<asp:TextBox ID="txtGPA" runat="server" Width="200"></asp:TextBox>
			</p>

            </p>
        </div>
    
    </form>
</body>
</html>

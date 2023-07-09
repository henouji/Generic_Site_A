import { Grid, GridItem } from "@chakra-ui/react";
import { Outlet } from "react-router-dom";
import Navbar from "./Navbar";
import Sidebar from "./Sidebar";

function DashboardLayout() {
  return (
    <Grid templateColumns="250px 1fr" bg="gray.200" minHeight="100vh">
      <Sidebar />
      <GridItem>
        <Navbar />
        <Outlet />
      </GridItem>
    </Grid>
  )
}

export default DashboardLayout
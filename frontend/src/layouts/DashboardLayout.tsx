import { Grid, GridItem } from "@chakra-ui/react";
import { Outlet } from "react-router-dom";
import Navbar from "./Navbar";

function DashboardLayout() {
  return (
    <Grid bg="gray.100" height="100vh">
      <GridItem>
        <Navbar />
        <Outlet />
      </GridItem>
    </Grid>
  )
}

export default DashboardLayout
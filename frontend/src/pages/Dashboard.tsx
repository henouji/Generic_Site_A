import { Box, Card, CardBody, CardHeader, Heading, SimpleGrid, Text } from "@chakra-ui/react";

function Dashboard() {
  return (
    <SimpleGrid minChildWidth={250} spacing={3} p="15px">
      <Box h="100px" bg="teal.400" boxShadow="sm"></Box>
      <Box h="100px" bg="teal.400" boxShadow="sm"></Box>
      <Box h="100px" bg="teal.400" boxShadow="sm"></Box>
      <Box h="100px" bg="teal.400" boxShadow="sm"></Box>
    </SimpleGrid>
    
  );
}

export default Dashboard;
import { 
  Box,
  Button,
  Center,
  Container,
  Flex,
  FormControl,
  FormLabel,
  Heading,
  Image,
  Input
} from "@chakra-ui/react";
import { Link } from "react-router-dom";

function Login() {
  return (
    <Flex width="100vw" height="90vh" alignItems="center" justifyContent="center">
      <Container maxW="sm">
        <Center>
          <Image boxSize='50px' src='/react.svg' alt='React App' />
        </Center>
        <Heading textAlign="center" size="md" my="30px">Generic Site A</Heading>
        <FormControl>
          <FormLabel>Username</FormLabel>
          <Input type='text' focusBorderColor='purple' size="sm"/>
        </FormControl>
        <FormControl my="20px">
          <FormLabel>Password</FormLabel>
          <Input type='password' focusBorderColor='purple' size="sm"/>
        </FormControl>
        <Box>
          <Button type="submit" colorScheme="purple" width="100%" size="sm"><Link to="/dashboard">Submit</Link></Button>
        </Box>
      </Container>
    </Flex>
  );

}

export default Login;
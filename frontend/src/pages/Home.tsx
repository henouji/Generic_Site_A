import { Box, Container, Link, Stack } from "@chakra-ui/react";

function Home() {
  return (
    <Box width="100vw">
      <Container maxW="container.xl">
        <Stack>
          <Link href="/login">Login</Link>
        </Stack>
      </Container>
    </Box>
  );
}

export default Home;
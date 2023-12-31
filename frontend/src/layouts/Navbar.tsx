import {
  Avatar,
  Box,
  Button,
  Flex,
  Heading,
  Menu,
  MenuButton,
  MenuDivider,
  MenuList,
  Spacer,
  Text
} from "@chakra-ui/react"

function Navbar() {return (
    <Flex as="nav" p="10px" bg="gray.50" alignItems="center" boxShadow='base'>
      <Heading size="sm" color="gray.700">Dashboard</Heading>
      <Spacer />

      <Menu>
        <MenuButton>
          <Avatar size="sm" name="" bg="purple.200" src='' />
        </MenuButton>
        <MenuList p="12px" bg='gray.50'>
          <Flex gap="10px" alignItems="center">
            <Avatar size="md" name="" bg="purple.200" src='' />
            <Box>
              abel@totga.cu
              <Text fontSize='xs'  color="gray">Desecrate</Text>
            </Box>
          </Flex>
          <MenuDivider />
          <Flex alignItems="center">
            <Button size="sm">Logout</Button>
          </Flex>
        </MenuList>
      </Menu>
    </Flex>
  )
}

export default Navbar
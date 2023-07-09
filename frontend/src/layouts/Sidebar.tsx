import { 
  Box,
  GridItem,
  Heading,
  LinkBox,
  LinkOverlay,
  List
} from "@chakra-ui/react"
import { Link, useLocation } from "react-router-dom"


function Sidebar() {
  const navs = ['Dashboard', 'Jobs', 'Lorem', 'Ipsum'];
  const location = useLocation().pathname.split('/');

  const listItemStyle = {
    color: 'white',
    bg: 'blackAlpha.400',
    borderLeftColor: 'teal.300',
    borderLeftWidth: '3px'
  }

  const defaultListItemStyle = {
    ':hover': {
      color: 'white',
      bg: 'whiteAlpha.100'
    }
  }

  return (
    <GridItem as="aside" minHeight="100vh" bg="gray.700" boxShadow="xl">
      <Box p="15px">
        <Heading as="h1" size="md" color="teal.300">Generic Site A</Heading>
      </Box>
      <List color="gray.400" fontSize="md" letterSpacing="wider">
        {navs.map(nav => (
          <LinkBox key={nav} as="li" p="10px 15px" sx={location[1] === nav.toLowerCase() ? listItemStyle : defaultListItemStyle}>
            <LinkOverlay as={Link} to={nav.toLowerCase()}>
              {nav}
            </LinkOverlay>
          </LinkBox>
        ))}
      </List>
    </GridItem>
  )
}

export default Sidebar
import React from 'react'
import ReactDOM from 'react-dom/client'
import Login from './pages/Login.tsx'
import './assets/index.css'
import { ChakraProvider } from '@chakra-ui/react'

ReactDOM.createRoot(document.getElementById('root') as HTMLElement).render(
  <React.StrictMode>
    <ChakraProvider>
      <Login />
    </ChakraProvider>
  </React.StrictMode>,
)

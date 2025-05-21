import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './Areas/Landing/LandingArea.tsx'
import { RouterProvider } from 'react-router'
import { router } from './Routers/AppRouter.tsx'
import { ToastContainer } from 'react-toastify'
import { Provider } from 'react-redux'
import { persistor, store } from './Stores/store.ts'
import { PersistGate } from 'redux-persist/integration/react'

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <Provider store={store}>
      <PersistGate loading={null} persistor={persistor}>
      
        <ToastContainer position='bottom-right' theme='colored'/>
        <RouterProvider router={router} />
        
      </PersistGate>
    </Provider>
  </StrictMode>,
)

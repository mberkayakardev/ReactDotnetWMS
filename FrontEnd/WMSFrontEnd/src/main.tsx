import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './Areas/Landing/LandingArea.tsx'
import { RouterProvider } from 'react-router'
import { router } from './Routers/AppRouter.tsx'
import { ToastContainer } from 'react-toastify'
import { Provider } from 'react-redux'
import { store } from './Stores/store.ts'

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <Provider store={store}>
      <ToastContainer position='bottom-right' theme='colored'/>
        <RouterProvider router={router} />
    </Provider>
  </StrictMode>,
)

import { Outlet, useNavigate } from 'react-router';
import './ApplicationArea.css';
import {
  CssBaseline, styled, useTheme, type CSSObject, type Theme,
  Box, AppBar as MuiAppBar, Toolbar, Typography, Divider,
  IconButton, Drawer as MuiDrawer, List, ListItem, ListItemButton,
  ListItemIcon, ListItemText, Collapse
} from '@mui/material';

import MenuIcon from '@mui/icons-material/Menu';
import ChevronLeftIcon from '@mui/icons-material/ChevronLeft';
import ChevronRightIcon from '@mui/icons-material/ChevronRight';
import InboxIcon from '@mui/icons-material/MoveToInbox';
import ExpandMore from '@mui/icons-material/ExpandMore';
import React, { useEffect, useState } from 'react';
import { UseAppDispatch, UseAppSelector } from '../../Stores/store';
import ExpandLess from '@mui/icons-material/ExpandLess';
import { fetchUserMenus } from '../../Pages/Application/UserPages/AuthSlice'; // Menü slice yolu

const drawerWidth = 240;

const openedMixin = (theme: Theme): CSSObject => ({
  width: drawerWidth,
  transition: theme.transitions.create('width', {
    easing: theme.transitions.easing.sharp,
    duration: theme.transitions.duration.enteringScreen,
  }),
  overflowX: 'hidden',
});

const closedMixin = (theme: Theme): CSSObject => ({
  transition: theme.transitions.create('width', {
    easing: theme.transitions.easing.sharp,
    duration: theme.transitions.duration.leavingScreen,
  }),
  overflowX: 'hidden',
  width: `calc(${theme.spacing(7)} + 1px)`,
  [theme.breakpoints.up('sm')]: {
    width: `calc(${theme.spacing(8)} + 1px)`,
  },
});

const DrawerHeader = styled('div')(({ theme }) => ({
  display: 'flex',
  alignItems: 'center',
  justifyContent: 'flex-end',
  padding: theme.spacing(0, 1),
  ...theme.mixins.toolbar,
}));

interface AppBarProps extends MuiAppBarProps {
  open?: boolean;
}

const AppBar = styled(MuiAppBar, {
  shouldForwardProp: (prop) => prop !== 'open',
})<AppBarProps>(({ theme, open }) => ({
  zIndex: theme.zIndex.drawer + 1,
  transition: theme.transitions.create(['width', 'margin'], {
    easing: theme.transitions.easing.sharp,
    duration: theme.transitions.duration.leavingScreen,
  }),
  ...(open && {
    marginLeft: drawerWidth,
    width: `calc(100% - ${drawerWidth}px)`,
    transition: theme.transitions.create(['width', 'margin'], {
      easing: theme.transitions.easing.sharp,
      duration: theme.transitions.duration.enteringScreen,
    }),
  }),
}));

const Drawer = styled(MuiDrawer, { shouldForwardProp: (prop) => prop !== 'open' })(
  ({ theme, open }) => ({
    width: drawerWidth,
    flexShrink: 0,
    whiteSpace: 'nowrap',
    boxSizing: 'border-box',
    ...(open && {
      ...openedMixin(theme),
      '& .MuiDrawer-paper': openedMixin(theme),
    }),
    ...(!open && {
      ...closedMixin(theme),
      '& .MuiDrawer-paper': closedMixin(theme),
    }),
  })
);

export default function ApplicationArea() {
  const theme = useTheme();
  const [open, setOpen] = useState(false);
  const navigate = useNavigate();
  const dispatch = UseAppDispatch();
  const [expandedMenus, setExpandedMenus] = useState<{ [key: number]: boolean }>({});

  const { menus: menuItems = [], loading, error } = UseAppSelector((state) => state.menu);
  const auth = UseAppSelector((state) => state.auth);

  useEffect(() => {
    if (auth?.user?.id) {
      dispatch(fetchUserMenus(auth.user.id));
    }
  }, [dispatch, auth?.user?.id]);

  const handleDrawerOpen = () => setOpen(true);
  const handleDrawerClose = () => setOpen(false);


    const toggleMenu = (id: number) => {
    setExpandedMenus((prev) => ({ ...prev, [id]: !prev[id] }));
  };


 const renderMenuItems = (item: AppReactMenuItem, depth: number = 0) => {
    const hasChildren = item.childMenus?.length > 0;
    const isExpanded = expandedMenus[item.id] ?? false;

    return (
      <React.Fragment key={item.id}>
        <ListItem disablePadding sx={{ display: 'block', pl: 2 * depth }}>
          <ListItemButton
            onClick={() => {
              if (hasChildren) {
                toggleMenu(item.id);
              } else if (item.menuTo) {
                navigate(item.menuTo);
              }
            }}
            sx={{
              minHeight: 48,
              justifyContent: open ? 'initial' : 'center',
              px: 2.5,
            }}
          >
            <ListItemIcon
              sx={{
                minWidth: 0,
                mr: open ? 3 : 'auto',
                justifyContent: 'center',
              }}
            >
              <InboxIcon />
            </ListItemIcon>
            <ListItemText primary={item.menuTextName} sx={{ opacity: open ? 1 : 0 }} />
            {hasChildren && (isExpanded ? <ExpandLess /> : <ExpandMore />)}
          </ListItemButton>
        </ListItem>
        {hasChildren && (
          <Collapse in={isExpanded} timeout="auto" unmountOnExit>
            <List component="div" disablePadding>
              {item.childMenus.map((child) => renderMenuItems(child, depth + 1))}
            </List>
          </Collapse>
        )}
      </React.Fragment>
    );
  };

  return (
    <Box sx={{ display: 'flex' }}>
      <CssBaseline />
      <AppBar position="fixed" open={open}>
        <Toolbar>
          <IconButton
            color="inherit"
            aria-label="open drawer"
            onClick={handleDrawerOpen}
            edge="start"
            sx={{ marginRight: 5, ...(open && { display: 'none' }) }}
          >
            <MenuIcon />
          </IconButton>
          <Typography variant="h6" noWrap component="div">
            Admin Paneli
          </Typography>
        </Toolbar>
      </AppBar>
      <Drawer variant="permanent" open={open}>
        <DrawerHeader>
          <IconButton onClick={handleDrawerClose}>
            {theme.direction === 'rtl' ? <ChevronRightIcon /> : <ChevronLeftIcon />}
          </IconButton>
        </DrawerHeader>
        <Divider />
        {loading && <Typography sx={{ px: 2, py: 1 }}>Menüler yükleniyor...</Typography>}
        {error && <Typography color="error" sx={{ px: 2, py: 1 }}>Hata: {error}</Typography>}
        <List>
          {menuItems.map((item) => renderMenuItems(item))}
        </List>
      </Drawer>
      <Box component="main" sx={{ flexGrow: 1, p: 3 }}>
        <DrawerHeader />
        <Outlet />
      </Box>
    </Box>
  );
}

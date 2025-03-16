import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { AppModule } from './app/app.module';

platformBrowserDynamic().bootstrapModule(AppModule, {
  ngZoneEventCoalescing: true,
})
  .catch(err => console.error(err));

  const getPreferredTheme = ():string => {
    return window.matchMedia('(prefers-color-scheme: dark)').matches ? 'dark' : 'light'
  }

  const setTheme = (theme:string): void => {
    console.log("Theme -> ", theme);
    if (theme === 'auto') {
      document.documentElement.setAttribute('data-bs-theme', (window.matchMedia('(prefers-color-scheme: dark)').matches ? 'dark' : 'light'))
    } else {
      document.documentElement.setAttribute('data-bs-theme', theme)
    }

  }

  window.matchMedia('(prefers-color-scheme: dark)').addEventListener('change', event => {
    setTheme(getPreferredTheme());
  });

  window.onload = ():void => {
    setTheme(getPreferredTheme())
  }

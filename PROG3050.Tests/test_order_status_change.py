from selenium import webdriver
from selenium.webdriver.common.by import By
import chromedriver_autoinstaller


chromedriver_autoinstaller.install()  # Check if the current version of chromedriver exists
                                      # and if it doesn't exist, download it automatically,
                                      # then add chromedriver to path

"""
Arrange
"""
# Tester1 navigates to the homepage
driver = webdriver.Chrome()
driver.get("https://localhost:7239/")

"""
Act
"""
# Tester1 login
driver.find_element(By.LINK_TEXT, "Login").click()
driver.find_element(By.ID, "Input_Email").send_keys("Admin")
driver.find_element(By.ID, "Input_Password").send_keys("Admin123!@")
driver.find_element(By.ID, "login-submit").click()

# Tester1 navigates to the games page
driver.find_element(By.ID, "nav-game").click()

# Tester1 clicks add to cart on a game
driver.find_element(By.CSS_SELECTOR, "tr:nth-child(2) .d-inline-block .btn").click()

# Tester1 navigates to the cart then checkout pages
driver.find_element(By.LINK_TEXT, "View Cart").click()
driver.find_element(By.LINK_TEXT, "Checkout").click()

# Fills out form
driver.find_element(By.ID, "Checkout_Street").send_keys("108 University Ave")
driver.find_element(By.ID, "Checkout_City").send_keys("Waterloo")
driver.find_element(By.ID, "Checkout_ProvinceId").click()
dropdown = driver.find_element(By.ID, "Checkout_ProvinceId")
dropdown.find_element(By.XPATH, "//option[. = 'ON']").click()
driver.find_element(By.ID, "Checkout_CountryId").click()
driver.find_element(By.ID, "Checkout_PostalCode").send_keys("N2J 2W2")
driver.find_element(By.ID, "Checkout_CreditCard").send_keys("4701322211111234")
driver.find_element(By.ID, "Checkout_CreditCardExpiry").send_keys("2026-12")
driver.find_element(By.ID, "Checkout_CVC").send_keys("837")

# Submit form
driver.find_element(By.CSS_SELECTOR, ".btn:nth-child(5)").click()

# Naviagte to admin orders
driver.find_element(By.ID, "dropdownMenuButton1").click()
driver.find_element(By.LINK_TEXT, "Orders").click()

# Navigate to edit the order (assuming no other orders) + update and save
driver.find_element(By.LINK_TEXT, "Edit").click()
driver.find_element(By.ID, "Status").send_keys("Processed")
driver.find_element(By.CSS_SELECTOR, ".form-group > .btn").click()

# Navigate to User Orders
driver.find_element(By.CSS_SELECTOR, ".dropdown:nth-child(2) > #dropdownMenuButton1").click()
driver.find_element(By.LINK_TEXT, "Orders").click()

"""
Assert
"""
# Assert order's element text is "Pending"
assert driver.find_element(By.CSS_SELECTOR, "td:nth-child(2)").text == "Processed"

"""
Clean up
"""
# Delete order
driver.find_element(By.ID, "dropdownMenuButton1").click()
driver.find_element(By.LINK_TEXT, "Orders").click()
driver.find_element(By.LINK_TEXT, "Delete").click()
driver.find_element(By.CSS_SELECTOR, ".btn-danger").click()

# Log out
driver.find_element(By.CSS_SELECTOR, ".dropdown:nth-child(2) > #dropdownMenuButton1").click()
driver.find_element(By.CSS_SELECTOR, ".btn-link").click()

driver.quit()
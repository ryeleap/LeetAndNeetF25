$path = "C:\Users\ripr5\devsrc\LeetAndNeetF25"
$repo = "C:\Users\ripr5\devsrc\LeetAndNeetF25"
$interval = 60  # seconds

$watcher = New-Object IO.FileSystemWatcher $path, "*.*"
$watcher.IncludeSubdirectories = $true
$watcher.EnableRaisingEvents = $true

$global:lastCommit = Get-Date "2000-01-01"

$action = {
    $now = Get-Date
    if (($now - $global:lastCommit).TotalSeconds -ge $using:interval) {
        Set-Location $using:repo
        git add .
        git commit -m "Auto-commit at $now" | Out-Null
        git push | Out-Null
        $global:lastCommit = $now
        Write-Host "Committed changes at $now"
    }
}

Register-ObjectEvent $watcher Changed -Action $action
Register-ObjectEvent $watcher Created -Action $action
Register-ObjectEvent $watcher Deleted -Action $action
Register-ObjectEvent $watcher Renamed -Action $action

Write-Host "Watching $path ... press Ctrl+C to stop."

while ($true) {
    Start-Sleep -Seconds 5
}
